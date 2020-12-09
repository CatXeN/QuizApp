import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-auth-container',
  templateUrl: './auth-container.component.html',
  styleUrls: ['./auth-container.component.scss']
})
export class AuthContainerComponent implements OnInit {

  register = new FormGroup({
    login: new FormControl(''),
    password: new FormControl(''),
  });

  constructor() { }

  ngOnInit() {
  }

}
