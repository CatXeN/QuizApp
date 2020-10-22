import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './components/login/login.component';
import { CoreModule } from '../../core/layouts/core.module';
import { AuthRoutingModule } from './auth-routing.module';
import { MaterialModule } from 'src/app/material';


@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    AuthRoutingModule,
    MaterialModule
  ],
  declarations: [LoginComponent]
})
export class AuthModule { }
