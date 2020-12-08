import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder, LogLevel } from '@microsoft/signalr';
import {from, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { MessagePackHubProtocol } from '@microsoft/signalr-protocol-msgpack';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  private hubConnection: HubConnection;
  public messages: string[];
  private connectionUrl = 'http://localhost:63764/gamehub';
  private apiUrl = 'http://localhost:63764/api/game';

  constructor(private http: HttpClient) { }

  public connect = () => {
    this.startConnection();
    this.addListeners();
  }

  public sendMessageToApi(message: string): Observable<object> {
    return this.http.post(this.apiUrl, message)
      .pipe(tap(_ => console.log('message sucessfully sent to api controller')));
  }

  public sendMessageToHub(message: string): Observable<void> {
    const promise = this.hubConnection.invoke('BroadcastAsync', message)
      .then(() => { console.log('message sent successfully to hub'); })
      .catch((err) => console.log('error while sending a message to hub: ' + err));

    return from(promise);
  }

  private getConnection(): HubConnection {
    return new HubConnectionBuilder()
      .withUrl(this.connectionUrl)
      .withHubProtocol(new MessagePackHubProtocol())
      .build();
  }

  private startConnection(): void {
    this.hubConnection = this.getConnection();

    this.hubConnection.start()
      .then(() => console.log('connection started'))
      .catch((err) => console.log('error while establishing signalr connection: ' + err));
  }

  private addListeners(): void {
    this.hubConnection.on('messageReceivedFromApi', (data: string) => {
      console.log('message received from API Controller');
      this.messages.push(data);
    });
    this.hubConnection.on('messageReceivedFromHub', (data: string) => {
      console.log('message received from Hub');
      this.messages.push(data);
    });
    this.hubConnection.on('newUserConnected', _ => {
      console.log('new user connected');
    });
  }
}
