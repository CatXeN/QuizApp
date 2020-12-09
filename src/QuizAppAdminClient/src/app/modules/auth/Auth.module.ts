import { AuthContainerComponent } from './container/auth-container/auth-container.component';
import { AuthRoutingModule } from './Auth-routing.module';
import { MaterialModule } from '../../shared/material';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModules } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    MaterialModule,
    SharedModules,
    AuthRoutingModule
  ],
  declarations: [AuthContainerComponent]
})
export class AuthModule { }
