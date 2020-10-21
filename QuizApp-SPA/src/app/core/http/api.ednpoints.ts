import { environment } from 'src/environments/environment';

export const apiEndpoints = {
    auth: {
        register: `${environment.apiUrl}/api/auth/register`,
        login: `${environment.apiUrl}/api/auth/login`
    }
};