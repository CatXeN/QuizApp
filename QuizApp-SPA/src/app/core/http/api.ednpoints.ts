import { environment } from '../../../environments/environment';

export const apiEndpoints = {
    auth: {
        register: `${environment.apiUrl}/api/auth/register`,
        login: `${environment.apiUrl}/api/auth/login`
    },
    category: {
        getCategory: `${environment.apiUrl}api/Category`
    }
};
