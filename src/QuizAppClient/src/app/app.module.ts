import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainLayoutComponent } from './core/layouts/main-layout/main-layout.component';
import { MaterialModule } from './shared/modules/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AuthModule } from './modules/auth/auth.module';
import { HomeModule } from './modules/home/home.module';
import { HttpClientModule } from '@angular/common/http';
import { SharedModules } from './shared/modules/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HomeModule,
    MaterialModule,
    BrowserAnimationsModule,
    AuthModule,
    HttpClientModule,
    SharedModules

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
