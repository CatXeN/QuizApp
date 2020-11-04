import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { StartPageComponent } from './components/start-page/start-page.component';
import { HomeRoutingModule } from './home-routing.module';
import { MaterialModule } from '../../shared/modules/material';
import { QuizCardComponent } from './components/quiz-card/quiz-card.component';
import { SharedModules } from 'src/app/shared/modules/shared.module';
import { ToolbarComponent } from 'src/app/shared/modules/toolbar/toolbar.component';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    HomeRoutingModule,
    MaterialModule, 
    SharedModules
  ],
  declarations: [StartPageComponent, QuizCardComponent]
})
export class HomeModule { }
