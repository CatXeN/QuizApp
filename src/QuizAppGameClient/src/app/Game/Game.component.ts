import { GameService } from './../Services/Game.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Game',
  templateUrl: './Game.component.html',
  styleUrls: ['./Game.component.scss']
})
export class GameComponent implements OnInit {
  signalList: string[] = [];

  constructor(private gameService: GameService) { }

  ngOnInit(): void {
    this.gameService.signalRecived.subscribe((signal: string) => {
      this.signalList.push(signal);
    });
  }

  buttoned() {
    this.gameService.SendMessage('Works!');
  }
}
