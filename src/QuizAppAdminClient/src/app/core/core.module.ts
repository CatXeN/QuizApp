import { MenuComponent } from './menu/menu.component';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SharedModules } from '../shared/shared.module';

@NgModule({
  declarations: [
    MenuComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    SharedModules,
    RouterModule
  ],
  exports: [MenuComponent]
})
export class CoreModule {}
