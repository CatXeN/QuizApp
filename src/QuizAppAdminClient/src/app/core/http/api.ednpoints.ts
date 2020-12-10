import { environment } from '../../../environments/environment';

export const apiEndpoints = {
    Home: {
        getCategories: `${environment.apiUrl}/api/category`
    }
};
