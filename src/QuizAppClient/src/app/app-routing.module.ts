import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainLayoutComponent } from './core/layouts/main-layout/main-layout.component';

const routes: Routes = [

  {
    path: '',
    data: {tittle: ''},
    component: MainLayoutComponent,
    children: [
      {
        path: '',
        loadChildren: () => import('./modules/home/home.module').then(x => x.HomeModule)
      },
      {
        path: 'auth',
        loadChildren: () => import('./modules/auth/auth.module').then(x => x.AuthModule)
      },

    ]
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
