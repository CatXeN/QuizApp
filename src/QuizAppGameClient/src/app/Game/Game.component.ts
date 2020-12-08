import { SignalRService } from './service/SignalR.service';
import { Component, OnInit } from '@angular/core';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Game',
  templateUrl: './Game.component.html',
  styleUrls: ['./Game.component.scss']
})
export class GameComponent implements OnInit {
  text = '';

  constructor(public signalRService: SignalRService) {

  }

  ngOnInit(): void {
    this.signalRService.connect();
  }

  sendMessage(): void {
    this.signalRService.sendMessageToHub(this.text).subscribe({
      next: _ => this.text = '',
      error: (err) => console.error(err)
    });
  }

}
