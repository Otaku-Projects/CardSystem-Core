import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { environment } from 'src/environments/environment';

import { AuthenticationHelper } from './authenticationHelper';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
        private authenticationHelper: AuthenticationHelper,
    ) { }

    // Login Auth Checking
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        if (environment.production) {
            const currentUser = this.authenticationHelper.CurrentUserValue;

            if (currentUser == null)
                this.router.navigate(['/login']);

            const currentUserRoutes = this.authenticationHelper.CurrentUserRoutes;
            var url = state.url;

            if (currentUserRoutes?.find(p => p.path.includes(url)))
                return true;
            else
                return false;
        }
        else //Dev mode
            return true;
    }
}