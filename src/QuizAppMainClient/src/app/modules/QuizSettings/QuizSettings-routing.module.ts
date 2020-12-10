import { QuizSettingsContainerComponent } from './container/QuizSettings-container/QuizSettings-container.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

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