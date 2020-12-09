import { AuthModule } from './modules/auth/Auth.module';
import { CategoryModule } from './modules/category/category.module';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { MainLayoutComponent } from './core/layouts/main-layout/main-layout.component';
import { CoreModule } from './core/core.module';
import { MainModule } from './modules/main/main.module';
import { SharedModules } from './shared/shared.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    SharedModules,
    MainModule,
    CategoryModule,
    CoreModule,
    AuthModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
