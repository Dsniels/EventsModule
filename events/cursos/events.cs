

using events.cursos;

public record CursoNotFound();

public record CursoFound(int cursoId, string title, string authorId);

public record CursoExists(int cursoId);
