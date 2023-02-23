import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { PrimeNgCommonModule } from './common.module';
import { UserListAndSearchComponent } from './components/user/list-and-search/list-and-search.component';
import { PagesRoutes } from './pages.routing';

@NgModule({
  imports: [
    PrimeNgCommonModule,
    RouterModule.forChild(PagesRoutes)
  ],
  declarations: [
    UserListAndSearchComponent
  ],
})
export class PagesModule { }
