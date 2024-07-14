import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthenticationRoutingModule } from './authentication-routing.module';
import { provideRouter } from '@angular/router';
import { routes } from '../app.routes';
import {provideHttpClient } from '@angular/common/http';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    AuthenticationRoutingModule,
  ],
  providers: [ provideRouter(routes), provideHttpClient()],
})
export class AuthenticationModule { }
