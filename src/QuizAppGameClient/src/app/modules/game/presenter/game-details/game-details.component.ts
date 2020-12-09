import { Component, OnInit } from '@angular/core';
import { GameService } from '../../services/Game.service';

@Component({
  selector: 'app-game-details',
  templateUrl: './game-details.component.html',
  styleUrls: ['./game-details.component.scss']
})
export class GameDetailsComponent implements OnInit {
  signalList: string[] = [];

  constructor(private gameService: GameService) { }

  //call gameService.SendMessage to send message on the hub

  ngOnInit(): void {
    this.gameService.signalRecived.subscribe((signal: string) => {
      this.signalList.push(signal);
      console.log(signal);
    });
  }
}
