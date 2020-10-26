import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-start-page',
  templateUrl: './start-page.component.html',
  styleUrls: ['./start-page.component.scss']
})
export class StartPageComponent implements OnInit {

  public burger: boolean = false;

  constructor() { }

  ngOnInit(): void {

  }

  isOpened(): void {
   this.burger = !this.burger;
  }
}
