import { apiEndpoints } from './../../../core/http/api.ednpoints';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from 'src/app/shared/models/category.model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http: HttpClient) { }

  getCatergories(): Observable<Category[]> {
    return this.http.get<Category[]>(apiEndpoints.Home.getCategories);
  }
}
