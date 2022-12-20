import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
// import { AuthInfo, AuthService, LoginModel, RouteInfo } from 'app/_libraries/card-system-core';
import { AuthenticationService, LoginModel } from '../_libraries/card-system-core';
import * as fs from "fs"

@Injectable({ providedIn: 'root' })
export class AuthenticationHelper {
    private APPLICATION_CODE = 'AAS';

    private STORAGE_NAME = 'USER_DETAILS';
    private STORAGE_ROUTES_NAME = 'USER_ROUTES';

    private currentUserSubject: BehaviorSubject<AuthInfo>;
    private currentUserRouteSubject: BehaviorSubject<RouteInfo[]>;

    public currentUser: Observable<AuthInfo>;
    public currentUserRoute: Observable<RouteInfo[]>;

    constructor(private authService: AuthenticationService, private router: Router) {
        let storagedName = localStorage.getItem(this.STORAGE_NAME);
        let storagedRouteName = localStorage.getItem(this.STORAGE_ROUTES_NAME);

        let emptyUser:AuthInfo = {
            accessToken: "",
        routes: [],
        twoFA: false,
        forgotPassword: false,
        errorMessage: ""}
        this.currentUserSubject = new BehaviorSubject<AuthInfo>(emptyUser);
        if(storagedName)
        this.currentUserSubject = new BehaviorSubject<AuthInfo>(JSON.parse(storagedName));

        this.currentUserRouteSubject = new BehaviorSubject<RouteInfo[]>([]);
        if(storagedRouteName)
        this.currentUserRouteSubject = new BehaviorSubject<RouteInfo[]>(JSON.parse(storagedRouteName));

        this.currentUser = this.currentUserSubject.asObservable();
        this.currentUserRoute = this.currentUserRouteSubject.asObservable();
    }

    public get CurrentUserValue(): AuthInfo {
        return this.currentUserSubject.value;
    }

    public get CurrentUserRoutes(): RouteInfo[] {
        return this.currentUserRouteSubject.value;
    }

    Login(username: string, password: string) {
        const data: LoginModel = {
            username: username,
            password: password,
            applicationCode: this.APPLICATION_CODE
        };

        return this.authService.authenticationLoginPost(data)
            .pipe(
                map(user => {
                    localStorage.setItem(this.STORAGE_NAME, JSON.stringify(user));
                    localStorage.setItem(this.STORAGE_ROUTES_NAME, JSON.stringify(user.routes));

                    this.currentUserRouteSubject.next(user.routes);
                    this.currentUserSubject.next(user);
                    //this.cookieService.set(this.COOKIE_NAME, 'True', null, null, null, false, "Strict");
                    return user;
                })
            );
    }

    Logout() {
        this.authService.apiAuthLogoutGet().subscribe(p => {
            localStorage.clear();
            this.currentUserSubject.next(null);
            this.currentUserRouteSubject.next(null);

            this.router.navigate(['/login']);
        });
    }
}

export interface AuthInfo { 
    accessToken: string;
    routes: Array<RouteInfo>;
    twoFA?: boolean;
    forgotPassword?: boolean;
    errorMessage?: string | null;
}

export interface RouteInfo { 
    path: string;
    title: string;
    icon: string;
    iconCss: string;
    iconName: string;
    isShowInMenu: boolean;
    _class: string;
    extralink: boolean;
    submenu: Array<RouteInfo>;
}

export interface UserLogin { 
    username: string;
    password: string;
    emailOtp?: string | null;
}

export interface ForgotPasswordView { 
    email?: string | null;
    otp?: string | null;
    applicationCode?: string | null;
}