import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { AlertHelper } from 'src/app/_helpers/alertHelper';
import { AuthenticationHelper } from 'src/app/_helpers/authenticationHelper';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styles: [`
        :host ::ng-deep .pi-eye,
        :host ::ng-deep .pi-eye-slash {
            transform:scale(1.6);
            margin-right: 1rem;
            color: var(--primary-color) !important;
        }
    `]
})
export class LoginComponent {

    valCheck: string[] = ['remember'];

    password!: string;
    email!: string;

    returnUrl: string;

    constructor(
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private alertHelper: AlertHelper,
        public layoutService: LayoutService, public authenticationHelper: AuthenticationHelper) {
            this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'] || '/user/list-and-search';
        }

    login(id:string, pwd:string){
        console.dir(id)
        console.dir(pwd)

        this.authenticationHelper.Login(id, pwd)
        .pipe(first()).subscribe(
            data => {
                this.router.navigate([this.returnUrl]);
            },
            error => {
                this.alertHelper.error(error.error.message);
            });
    }
}
