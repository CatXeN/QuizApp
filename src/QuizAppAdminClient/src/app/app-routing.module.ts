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
        loadChildren: () => import('../app/modules/auth/Auth.module').then(x => x.AuthModule)
      },
      {
        path: 'home',
        loadChildren: () => import('../app/modules/main/main.module').then(x => x.MainModule)
      },
      {
        path: 'category',
        loadChildren: () => import('../app/modules/category/category.module').then(x => x.CategoryModule)
      }
    ]
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
