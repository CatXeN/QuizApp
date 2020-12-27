import { environment } from 'src/environments/environment';

export const apiEndpoints = {

    Category: {
        getCategoryList: `${environment.apiUrl}/api/Category`
    },
   Quiz: {
       getAllQuizesFromCategory: `${environment.apiUrl}/api/Quiz/getQuizzesFromCategory/{0}`,
     getQuizById: `${environment.apiUrl}/api/Quiz/{0}`
   }

};
