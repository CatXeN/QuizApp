import { Category } from './../../../../shared/models/category.model';
import { DashboardService } from './../../service/dashboard-service.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard-category',
  templateUrl: './dashboard-category.component.html',
  styleUrls: ['./dashboard-category.component.scss']
})
export class DashboardCategoryComponent implements OnInit {

  category: Category[];
  
  constructor(private dashboardService: DashboardService) { }
  
  ngOnInit() {
    this.getCategoryName();
  }

  getCategoryName() {
    this.dashboardService.getCategories().subscribe(c => {
      this.category = c;
      console.log(c);
    })
  }
}
