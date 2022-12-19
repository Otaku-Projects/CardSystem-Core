import { Injectable, Injector, InjectionToken, Inject } from '@angular/core';
import { Observable, throwError, BehaviorSubject } from 'rxjs';
import {
    HttpInterceptor, HttpRequest, HttpHandler, HttpErrorResponse, HttpSentEvent, HttpHeaderResponse,
    HttpProgressEvent, HttpResponse, HttpUserEvent
} from '@angular/common/http';
import { timeout, catchError, switchMap, finalize } from 'rxjs/operators';
import { Router } from '@angular/router';
import { AuthenticationService } from './authenticationHelper';
import { AlertHelper } from '../alertHelper';
import { AuthInfo } from 'app/_libraries';


export const DEFAULT_TIMEOUT = new InjectionToken<number>('defaultTimeout');


@Injectable()
export class JwtInterceptor implements HttpInterceptor {

    tokenSubject: BehaviorSubject<string> = new BehaviorSubject<string>(null);
    isRefreshingToken = false;

    constructor(private injector: Injector,
        private router: Router,
        private alertHelper: AlertHelper,
        private authenticationService: AuthenticationService,
        @Inject(DEFAULT_TIMEOUT) protected defaultTimeout: number) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpSentEvent
        | HttpHeaderResponse
        | HttpProgressEvent
        | HttpResponse<any>
        | HttpUserEvent<any>> {

        const timeoutValue = Number(request.headers.get('timeout')) || this.defaultTimeout;

        const user = this.authenticationService.CurrentUserValue
        request = this.GetTokenRequest(user, request);

        return next.handle(request).pipe(timeout(timeoutValue), catchError(error => {
            if (error instanceof HttpErrorResponse) {
                switch ((<HttpErrorResponse>error).status) {
                    case 400:
                        console.log(400);
                        return this.handle400Error(error);
                    case 401:
                        console.log(401);
                        return this.handle401Error(error);
                    default:
                        this.handleError(error);
                }
            }
        }));

    }

    private GetTokenRequest(user: AuthInfo, request: HttpRequest<any>) {
        if (user) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${user.accessToken}`,
                    'Content-Type': 'application/json'
                }
            });
        }
        return request;
    }
    setRequestHeaders() {
        const user = this.authenticationService.CurrentUserValue
        return {
          Authorization: `Bearer ${user.accessToken}`
        };
      }
    
    //Error Handling
    private handle400Error(error) {
        var validationSummary = [];
        let validationErrorDictionary = error.error.ModelState;
        if (validationErrorDictionary != null) {
            for (var fieldName in validationErrorDictionary) {
                if (validationErrorDictionary.hasOwnProperty(fieldName)) {
                    validationSummary.push(validationErrorDictionary[fieldName]);
                    //console.log(validationErrorDictionary[fieldName]);
                }
            }
            this.alertHelper.error(validationSummary.join("<br>"));
        }
        else {
            return throwError(error);
        }
    }

    private handle401Error(error) {
        this.alertHelper.error('login session expired!');
        this.router.navigate(['/login']);
        return throwError("Please login again!");
    }

    handleError(error: Error | HttpErrorResponse | String) {
        let errorMessage = '';
        if (error instanceof HttpErrorResponse) {
            // Server error happened
            if (!navigator.onLine) {
                // No Internet connection
                this.alertHelper.error('No Internet Connection');
            } else if (error.status === 408) {
                this.alertHelper.error('Request Timeout');
            } else if (error.status === 0) {
                this.alertHelper.error('Cannot connect to server.');
            } else {
                this.alertHelper.error(error.error.Message);
            }
        }
        else if (error instanceof ErrorEvent) {
            errorMessage = `Error: ${error.error.Message}`;
            this.alertHelper.error(errorMessage);
        }
        else {
            this.alertHelper.error(error.toString());
        }
    }
}

