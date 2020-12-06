import { DashboardHeaderComponent } from './presenter/dashboard-header/dashboard-header.component';
import { CoreModule } from './../../core/core.module';
import { DashboardContainerComponent } from './container/dashboard-container/dashboard-container.component';
import { SharedModule } from './../../shared/modules/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardRoutingModule } from './dashboard-routing.module';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    SharedModule,
    DashboardRoutingModule
  ],
  declarations: [DashboardContainerComponent, DashboardHeaderComponent]
})
export class DashboardModule { }
