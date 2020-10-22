import { RegisterComponent } from './components/register/register.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './components/login/login.component';
import { CoreModule } from '../../core/layouts/core.module';
import { AuthRoutingModule } from './auth-routing.module';
import { MaterialModule } from 'src/app/material';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    AuthRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule
  ],
  declarations: [LoginComponent, RegisterComponent]
})
export class AuthModule { }
