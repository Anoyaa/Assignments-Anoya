import { Routes } from '@angular/router';

export const routes: Routes = [
    {path:'alert-me', component:AlertMeComponent},
    {path:'google-website-link',component:GoogleLinksComponent},
    {path:'leap-year',component:LeapYearComponent},
    {path:'country-table',component:CountryTableComponent},
    {path:'lists-n-nestedlists',component:ListsNNestedlistsComponent},
    {path:'shopping-list',component:ShoppingListComponent}
];

import { AlertMeComponent } from './alert-me/alert-me.component';
import { GoogleLinksComponent } from './google-links/google-links.component';
import { LeapYearComponent } from './leap-year/leap-year.component';
import { CountryTableComponent } from './country-table/country-table.component';
import { ListsNNestedlistsComponent } from './lists-n-nestedlists/lists-n-nestedlists.component';
import { ShoppingListComponent } from './shopping-list/shopping-list.component';

