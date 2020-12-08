import { Category } from './../../../../shared/models/category.model';
import { DashboardService } from './../../service/dashboard-service.service';
import { Component, OnInit } from '@angular/core';
import { Quiz } from 'src/app/shared/models/quiz.model';

@Component({
  selector: 'app-dashboard-category',
  templateUrl: './dashboard-category.component.html',
  styleUrls: ['./dashboard-category.component.scss']
})
export class DashboardCategoryComponent implements OnInit {

  category: Category[];
  quizes: Quiz[];

  constructor(private dashboardService: DashboardService) { }
  
  ngOnInit() {
    this.getCategoryName();
    this.getTop20Quizes();
  }

  getTop20Quizes() {
    this.dashboardService.getTop20().subscribe(q => {
      console.log(q);
    });
  }

  getCategoryName() {
    this.dashboardService.getCategories().subscribe(c => {
      this.category = c;
    })
  }
}
