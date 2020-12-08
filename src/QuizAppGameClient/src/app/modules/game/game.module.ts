import { MaterialModule } from './../../shared/material';
import { GameDetailsContainerComponent } from './container/game-details-container/game-details-container.component';
import { GameDetailsComponent } from './presenter/game-details/game-details.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { GameRoutingModule } from './game-routing.module';
import { SharedModules } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    GameRoutingModule,
    MaterialModule,
    SharedModules
  ],
  declarations: [GameDetailsComponent, GameDetailsContainerComponent]
})
export class GameModule { }
