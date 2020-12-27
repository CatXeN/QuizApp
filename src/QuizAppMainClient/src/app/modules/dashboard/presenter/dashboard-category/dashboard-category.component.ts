import { Quiz } from './../../../../shared/models/quiz.model';
import { Category } from './../../../../shared/models/category.model';
import { DashboardService } from './../../service/dashboard-service.service';
import { Component, OnInit } from '@angular/core';
import {map, switchMap} from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-dashboard-category',
  templateUrl: './dashboard-category.component.html',
  styleUrls: ['./dashboard-category.component.scss']
})
export class DashboardCategoryComponent implements OnInit {

  category: Category[];
  categoryNumber = 10;
  quizes: Quiz[];

  constructor(private dashboardService: DashboardService) { }

  ngOnInit(): void {
    // this.getCategoryName();
    }

  // getCategoryName() {
  //   return this.dashboardService.getCategories().pipe(switchMap((_categories: any) => 
  //   this.dashboardService.GetAllQuizes(_categories.categoryId).map(x => {
  //     this.quizes = x;
  //   }))) }
  //   }
}
