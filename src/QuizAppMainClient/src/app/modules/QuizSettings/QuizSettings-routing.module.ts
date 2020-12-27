import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {QuizSettingsContainerComponent} from './container/quiz-settings-container/quiz-settings-container.component';

const routes: Routes = [

    {
        path: '',
        component: QuizSettingsContainerComponent
    }

];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
export class QuizSettingsRoutingModule {}
