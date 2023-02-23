import { Routes } from '@angular/router';
import { UserListAndSearchComponent } from './components/user/list-and-search/list-and-search.component';

export const PagesRoutes: Routes = [
	{
		path: 'user',
		children: [
			{
				path: 'list-and-search',
        component: UserListAndSearchComponent,
				// canActivate: [AuthGuard],
				data: {
					title: 'Contract Management List',
					urls: [
						{ title: 'Manager' },
						{ title: 'Contract' },
						{ title: 'List' }
					]
				}
			},
		]
	},
];
