import { environment } from '../../../environments/environment';

export const apiEndpoints = {
    auth: {
        register: `${environment.apiUrl}/api/auth/register`,
        login: `${environment.apiUrl}/api/auth/login`
    },
    category: {
        getCategory: `${environment.apiUrl}/api/Category`
    },
    quiz: {
        getQuiz: `${environment.apiUrl}/api/Quiz `
    },
    quest: {
        getSingleQuest: `${environment.apiUrl}/api/Quest/single/{0}`,
        getQuest: `${environment.apiUrl}/api/Quest/{0}`
    }
};
