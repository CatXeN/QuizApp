import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardContainerComponent } from './container/dashboard-container/dashboard-container.component';

const routes: Routes = [

    {
        path: '',
        component: DashboardContainerComponent
    }

];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
export class DashboardRoutingModule {}