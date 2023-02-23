import { NgModule } from '@angular/core';

//PrimeNg
import { InputTextModule } from "primeng/inputtext";
import { InputTextareaModule } from 'primeng/inputtextarea';
import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';
import { CheckboxModule } from 'primeng/checkbox';
import { RadioButtonModule } from "primeng/radiobutton";
import {InputSwitchModule} from 'primeng/inputswitch';
import {ToggleButtonModule} from 'primeng/togglebutton';
import { ColorPickerModule } from 'primeng/colorpicker';
import { TableModule } from 'primeng/table';
import { DropdownModule } from 'primeng/dropdown';
import { MultiSelectModule } from 'primeng/multiselect';
import { DragDropModule as primeDragDropModule } from 'primeng/dragdrop';
import { CalendarModule } from 'primeng/calendar';
import { DividerModule } from 'primeng/divider';
import { InputNumberModule } from 'primeng/inputnumber';
import { DialogModule } from 'primeng/dialog';
import {ConfirmDialogModule} from 'primeng/confirmdialog';
import { AutoCompleteModule } from 'primeng/autocomplete';
import {AccordionModule} from 'primeng/accordion';
import {StepsModule} from 'primeng/steps';
import {ImageModule} from 'primeng/image';
import {TabViewModule} from 'primeng/tabview';
import {FileUploadModule} from 'primeng/fileupload';
import {ChipsModule} from 'primeng/chips';
import { TreeModule } from "primeng/tree";
import { TimelineModule } from "primeng/timeline";
import { CardModule } from "primeng/card";

import { TooltipModule } from 'primeng/tooltip';
import { BadgeModule } from 'primeng/badge';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import {SkeletonModule} from 'primeng/skeleton';
import { GMapModule } from "primeng/gmap";
import { SecurityContext } from "@angular/core";
import {TreeTableModule} from 'primeng/treetable';
import { PasswordModule } from "primeng/password";
import {GalleriaModule} from 'primeng/galleria';

@NgModule({
  declarations: [],
  exports: [
    GalleriaModule,
    InputTextModule,
    InputTextareaModule,
    ButtonModule,
    RippleModule,
    CheckboxModule,
    RadioButtonModule,
    InputSwitchModule,
    ToggleButtonModule,
    ColorPickerModule,
    TableModule,
    DropdownModule,
    MultiSelectModule,
    primeDragDropModule,
    CalendarModule,
    DividerModule,
    InputNumberModule,
    DialogModule,
    ConfirmDialogModule,
    AutoCompleteModule,
    TreeModule,
    SkeletonModule,
    ProgressSpinnerModule,
    AccordionModule,
    StepsModule,
    FileUploadModule,
    TimelineModule,
    CardModule,
    GMapModule,
    TooltipModule,
    BadgeModule,
    ImageModule,
    TabViewModule,
    ChipsModule,
    TreeTableModule,
    PasswordModule,
  ]
})
export class PrimeNgCommonModule { }
