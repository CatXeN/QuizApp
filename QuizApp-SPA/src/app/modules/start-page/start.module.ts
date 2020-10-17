import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { StartPageComponent } from './components/start-page/start-page.component';
import { StartPageRoutingModule } from './start-routing.module';
import { MaterialModule } from 'src/app/material';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    StartPageRoutingModule,
    MaterialModule
  ],
  declarations: [StartPageComponent]
})
export class StartModule { }
