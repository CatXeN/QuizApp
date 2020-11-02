import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { StartPageComponent } from './components/start-page/start-page.component';
import { HomeRoutingModule } from './home-routing.module';
import { HamburgerComponent } from './components/hamburger/hamburger.component';
import { MaterialModule } from '../../shared/modules/material';
import { QuizCardComponent } from './components/quiz-card/quiz-card.component';


@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    HomeRoutingModule,
    MaterialModule
  ],
  declarations: [StartPageComponent, HamburgerComponent, QuizCardComponent]
})
export class HomeModule { }
