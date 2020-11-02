import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { apiEndpoints } from '../../../core/http/api.ednpoints';
import { Category } from '../../../shared/Models/category.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

constructor(private http: HttpClient) {}

  getCategory(): Observable<Category[]> {
    return this.http.get<Category[]>(apiEndpoints.category.getCategory);
  }
}
