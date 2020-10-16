import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../../core/layouts/core.module';
import { StartPageComponent } from './components/start-page/start-page.component';
import { StartPageRoutingModule } from './start-routing.module';

@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    StartPageRoutingModule
  ],
  declarations: [StartPageComponent]
})
export class StartModule { }
