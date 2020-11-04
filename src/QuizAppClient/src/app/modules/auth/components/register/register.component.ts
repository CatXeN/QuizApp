import { AuthService } from './../../service/auth.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  hide = true;
  accepted = false;

  registerForm = new FormGroup({
    email: new FormControl(''),
    username: new FormControl(''),
    password: new FormControl(''),
    repeatPassword: new FormControl(''),
    role: new FormControl('USER')
  });

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit(): void {}

  register(): void {
    if (this.registerForm.value.password === this.registerForm.value.repeatPassword)
    {
      this.authService.register(this.registerForm.value).subscribe(x => {
        this.router.navigate(['/auth']);
      });
    }
  }
}
