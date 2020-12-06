import { SharedModule } from './../shared/modules/shared.module';
import { MainComponent } from './layouts/main/main.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


@NgModule({
  imports: [
    CommonModule,
    SharedModule,
  ],
  declarations: []
})
export class CoreModule { }
