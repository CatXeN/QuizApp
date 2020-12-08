import { AppRoutingModule } from './app-routing.module';
import { MaterialModule } from './shared/material';
import { MainLayoutComponent } from './core/layouts/main-layout/main-layout.component';
import { GameModule } from './modules/game/game.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { SharedModules } from './shared/shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent
   ],
  imports: [
    RouterModule,
    BrowserModule,
    GameModule,
    MaterialModule,
    HttpClientModule,
    SharedModules,
    BrowserAnimationsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
