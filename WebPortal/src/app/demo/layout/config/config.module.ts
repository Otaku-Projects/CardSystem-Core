import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SidebarModule } from 'primeng/sidebar';
import { RadioButtonModule } from 'primeng/radiobutton';
import { ButtonModule } from 'primeng/button';
import { InputSwitchModule } from 'primeng/inputswitch';
import { AppConfigComponent } from './app.config.component';

import { ToastModule } from 'primeng/toast';
import { MessageService } from 'primeng/api';

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        SidebarModule,
        RadioButtonModule,
        ButtonModule,
        InputSwitchModule,
        ToastModule
    ],
    declarations: [
        AppConfigComponent
    ],
    exports: [
        AppConfigComponent
    ],
    providers: [
        MessageService
    ]
})
export class AppConfigModule { }
