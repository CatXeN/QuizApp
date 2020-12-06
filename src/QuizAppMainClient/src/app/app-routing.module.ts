import { MainComponent } from './core/layouts/main/main.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
{
  path: '',
  data: {title: 'dashboard'},
  component: MainComponent,
  children: [
    {
      path: '',
      loadChildren: () => import('./modules/dashboard/dashboard.module').then(m => m.DashboardModule)
    }
  ]
}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
