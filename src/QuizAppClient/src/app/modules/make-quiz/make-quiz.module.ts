import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { MaterialModule } from '../../shared/modules/material';
import { MakeQuizRoutingModule } from './make-quiz-routing.module';
import { MakeQuizComponent } from './components/make-quiz/make-quiz.component';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    MaterialModule,
    MakeQuizRoutingModule
  ],
  declarations: [MakeQuizComponent]
})
export class MakeQuizModule { }
