import { EventEmitter, Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';

@Injectable({
  providedIn: 'root'
})
export class GameService {
  private hubConnection: signalR.HubConnection;
  signalRecived = new EventEmitter<string>();

  constructor() {
    this.buildConnection();
    this.startConnection();
  }

  private buildConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('http://localhost:54614/gamehub')
      .build();
  }

  private startConnection = () => {
    this.hubConnection
      .start()
      .then(() => {
        console.log('Connection started...');
        this.registerSignalEvents();
      })
      .catch(err => {
        console.log('Error while starting connection ...' + err);

        setTimeout(() => {
          this.startConnection();
        }, 3000);
      });
  }

  private registerSignalEvents(): void {
    this.hubConnection.on('ReceiveMessage', (data: string) => {
        this.signalRecived.emit(data);
    });
  }

  public SendMessage(text: string): void {
    this.hubConnection.invoke('SendMessage', text);
  }
}
