import { environment } from 'src/environments/environment';

export const apiEndpoints = {
  
    Category: {
        getCategoryList: `${environment.apiUrl}/api/Category`
    },
   Quiz: {
       getTopQuizes: `${environment.apiUrl}/api/Quiz/twenty`
   }

};