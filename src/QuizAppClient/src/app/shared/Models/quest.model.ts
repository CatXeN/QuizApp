import { Category } from './category.model';
import { Quiz } from './quiz.model';

export interface Quest {
    questId: number;
    description: string;
    time: number;
    answerA: string;
    answerB: string;
    answerC: string;
    answerD: string;
    correctAnswer: number;
    imageUrl: string;
    quizId: number;
    quiz: Quiz;
    categoryId: number;
    category: Category;
}