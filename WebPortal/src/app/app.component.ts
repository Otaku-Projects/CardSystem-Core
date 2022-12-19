import { Component, OnInit } from '@angular/core';
import { PrimeNGConfig } from 'primeng/api';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

    constructor(private primengConfig: PrimeNGConfig, private route: ActivatedRoute,
        private router: Router) {
            this.router.navigate(["auth/login"])
    }

    ngOnInit() {
        this.primengConfig.ripple = true;
    }
}
