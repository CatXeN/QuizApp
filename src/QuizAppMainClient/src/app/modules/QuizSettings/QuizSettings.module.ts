import { QuizSettingsRoutingModule } from './QuizSettings-routing.module';
import { CoreModule } from '../../core/core.module';
import { SharedModule } from '../../shared/modules/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {QuizSettingsContainerComponent} from './container/quiz-settings-container/quiz-settings-container.component';
import {QuizSettingsViewComponent} from './presenter/quiz-settings-view/quiz-settings-view.component';


@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    SharedModule,
    QuizSettingsRoutingModule,
  ],
  declarations: [ QuizSettingsContainerComponent, QuizSettingsViewComponent  ]
})
export class QuizSettingsModule { }
