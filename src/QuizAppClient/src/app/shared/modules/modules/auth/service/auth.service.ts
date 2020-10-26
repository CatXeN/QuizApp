import { apiEndpoints } from './../../../core/http/api.ednpoints';
import { User } from './../../../shared/Models/user.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  jwtHelper = new JwtHelperService();
  decodedToken: any;

  constructor(private http: HttpClient) {}

  register(model: User): Observable<number>{
    return this.http.post<number>(apiEndpoints.auth.register, model);
  }

  login(model: User): Observable<void> {
    return this.http.post<void>(apiEndpoints.auth.login, model)
      .pipe(map((response: any) => {
        const user = response;
        if (user) {
          localStorage.setItem('token', user.token);
          this.decodedToken = this.jwtHelper.decodeToken(user.token);
          localStorage.setItem('userId', this.decodedToken.nameid);
        }
      }));
  }

  tokenExpiredAndLoggedIn(): boolean {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }
}
