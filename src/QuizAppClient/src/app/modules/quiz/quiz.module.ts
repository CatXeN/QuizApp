import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { MaterialModule } from '../../shared/modules/material';
import { SharedModules } from '../../shared/modules/shared.module'
import { QuizRoutingModule } from './quiz-routing.module';
import { QuizComponent } from './components/quiz/quiz.component';
import 'src/app/core/extensions/string.formater';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    QuizRoutingModule,
    MaterialModule, 
    SharedModules,
  ],
  declarations: [QuizComponent]
})
export class QuizModule { }
