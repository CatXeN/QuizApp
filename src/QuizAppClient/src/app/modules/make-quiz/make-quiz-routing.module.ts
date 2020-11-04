import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MakeQuizComponent } from './components/make-quiz/make-quiz.component';

const routes: Routes = [
  {
   path: '',
   component:  MakeQuizComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MakeQuizRoutingModule {}
