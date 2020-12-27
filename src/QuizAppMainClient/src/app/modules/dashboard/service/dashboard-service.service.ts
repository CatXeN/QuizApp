import { Quiz } from './../../../shared/models/quiz.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { apiEndpoints } from 'src/app/core/http/api.endpoints';
import { Category } from 'src/app/shared/models/category.model';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

constructor(private http: HttpClient) { }

getCategories(): Observable<Category[]> {
  return this.http.get<Category[]>(apiEndpoints.Category.getCategoryList);
}

GetAllQuizes(model: Category) {
  return this.http.get(apiEndpoints.Quiz.getAllQuizesFromCategory.format(String(model.categoryId)));
}

}
