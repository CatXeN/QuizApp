import { MainRoutingModule } from './main-routing.module';
import { MainContainerComponent } from './container/main-container/main-container.component';
import { MaterialModule } from '../../shared/material';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModules } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    MaterialModule,
    SharedModules,
    MainRoutingModule
  ],
  declarations: [MainContainerComponent]
})
export class MainModule { }
