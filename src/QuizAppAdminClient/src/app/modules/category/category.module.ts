import { CategoryRoutingModule } from './category-routing.module';
import { CategoryContainerComponent } from './container/category-container/category-container.component';
import { MaterialModule } from '../../shared/material';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModules } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    MaterialModule,
    SharedModules,
    CategoryRoutingModule
  ],
  declarations: [CategoryContainerComponent]
})
export class CategoryModule { }
