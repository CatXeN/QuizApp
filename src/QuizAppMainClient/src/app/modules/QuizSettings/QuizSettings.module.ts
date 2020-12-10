import { QuizSettingsRoutingModule } from './QuizSettings-routing.module';
import { QuizSettingsContainerComponent } from './container/QuizSettings-container/QuizSettings-container.component';
import { CoreModule } from '../../core/core.module';
import { SharedModule } from '../../shared/modules/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    SharedModule,
    QuizSettingsRoutingModule
  ],
  declarations: [ QuizSettingsContainerComponent]
})
export class QuizSettingsModule { }
