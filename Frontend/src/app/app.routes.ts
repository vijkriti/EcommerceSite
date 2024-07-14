import { Routes } from '@angular/router';
import { HomeComponent } from './commercial/home/home.component';

export const routes: Routes = [
    {path:'auth',loadChildren:()=>import('./authentication/authentication.module').then(m=>m.AuthenticationModule)},
    {path:'commercial',loadChildren:()=>import('./commercial/commercial.module').then(m=>m.CommercialModule)},
    { path: '', component: HomeComponent }
];
